

(window.BlazorWerks || (window.BlazorWerks = {})).Bootstrap = (function () {

    const DEBUG = false;

    const PROXY_EVENT = "bootstrap-proxy";

    const NET_HANDLER = "bootstrap";

    let propList = [
        {
            "name": "Alert",
            "selector": ".alert",
            "methods": ["close"],
            "events": ["close.bs.alert", "closed.bs.alert"]
        },
        {
            "name": "Button",
            "selector": ".btn",
            "methods": ["toggle"],
            "events": []
        },
        {
            "name": "Carousel",
            "selector": ".carousel",
            "methods": ["next", "prev", "cycle", "pause", "to"],
            "events": ["slide.bs.carousel", "slid.bs.carousel"]
        },
        {
            "name": "Collapse",
            "selector": ".collapse",
            "methods": ["show", "hide", "toggle"],
            "events": ["show.bs.collapse", "shown.bs.collapse", "hide.bs.collapse", "hidden.bs.collapse"]
        },
        {
            "name": "Dropdown",
            "selector": ".dropdown-toggle",
            "methods": ["show", "hide", "toggle", "update"],
            "events": ["show.bs.dropdown", "shown.bs.dropdown", "hide.bs.dropdown", "hidden.bs.dropdown"]
        },
        {
            "name": "Modal",
            "selector": ".modal",
            "methods": ["show", "hide", "toggle", "handleUpdate"],
            "events": ["show.bs.modal", "shown.bs.modal", "hide.bs.modal", "hidden.bs.modal", "hidePrevented.bs.modal"]
        },
        {
            "name": "Offcanvas",
            "selector": ".offcanvas",
            "methods": ["show", "hide", "toggle"],
            "events": ["show.bs.offcanvas", "hide.bs.offcanvas", "hidden.bs.offcanvas"]
        },
        {
            "name": "Popover",
            "selector": "[data-bs-toggle=\"popover\"]",
            "methods": ["show", "hide", "toggle", "update", "enable", "disable", "toggleEnabled"],
            "events": ["show.bs.popover", "shown.bs.popover", "hide.bs.popover", "hidden.bs.popover", "inserted.bs.popover"]
        },
        {
            "name": "ScrollSpy",
            "selector": "[data-bs-spy=\"scroll\"]",
            "methods": ["refresh"],
            "events": ["activate.bs.scrollspy"]
        },
        {
            "name": "Tab",
            "selector": "[data-bs-toggle=\"tab\"]",
            "methods": ["show"],
            "events": ["show.bs.tab", "shown.bs.tab", "hide.bs.tab", "hidden.bs.tab"]
        },
        {
            "name": "Toast",
            "selector": ".toast",
            "methods": ["show", "hide"],
            "events": ["show.bs.toast", "shown.bs.toast", "hide.bs.toast", "hidden.bs.toast"]
        },
        {
            "name": "Tooltip",
            "selector": "[data-bs-toggle=\"tooltip\"]",
            "methods": ["show", "hide", "toggle", "update", "enable", "disable", "toggleEnabled"],
            "events": ["show.bs.tooltip", "shown.bs.tooltip", "hide.bs.tooltip", "hidden.bs.tooltip", "inserted.bs.tooltip"]
        }
    ];


    // an array of all bootstrap component names

    function names() {
        return propList.map(function (p) { return p.name; });
    }

    // an array of all bootstrap events

    function events() {
        return propList.reduce(function (prev, current) { return prev.concat(current.events); }, []);
    };

    // an array of all bootstrap component css selectors

    function selectors() {
        return propList.map(function (p) { return p.selector; });
    };

    // an array of all bootstrap method names

    function methods() {
        return propList.reduce(function (prev, current) { return prev.concat(current.methods); }, [])
            .filter(function (value, index, self) { return self.indexOf(value) === index; });
    }

    // returns props for the named component or an array of all props when name is omitted

    function getProps(name) {

        if (typeof name === undefined) return propList;

        if (typeof name === "string") {
            let i = propList.map(function (p) { return p.name.toLowerCase(); }).indexOf(name.toLocaleLowerCase());
            return i < 0 ? undefined : propList[i];
        }

        // else assume name is already a props object
        return name;
    };

    // An event proxy that passes bootstrap events to .NET
    // If properties are added or modified then the C# event class
    // will need to be likewise modified to receive them.

    function eventProxy(e) {
        e.target.dispatchEvent(new CustomEvent(PROXY_EVENT, {
            bubbles: true,
            detail: {

                //origianl event
                eventType: e.type,
                isTrusted: e.isTrusted,
                timeStamp: Math.round(e.timeStamp),

                // target
                id: e.target.id,
                className: e.target.className,
                tagName: e.target.tagName,

                // carousel events only
                direction: e.direction,
                from: e.from,
                to: e.to
            }
        }));
    }

    // name = Bootstrap component name, target is an ElementReference or css selector
    // returns the closest parent or child element matching the Bootstrap component type.

    function getTarget(name, target) {

        let props = getProps(name);

        if (typeof target === "string") target = document.querySelector(target);

        return target.matches(props.selector) ? target : target.querySelector(props.selector);
    }


    // invokes a bootstrap component method

    function invoke(name, target, method, ...args) {

        let props = getProps(name);

        target = getTarget(props, target);

        let instance = bootstrap[props.name].getOrCreateInstance(target);

        if (typeof method === "string") instance[method](args);
    }



    function initialize() {

        // Carousel Fix
        // Carousels don't auto-play under Blazor as they are rendered after the DOMContentLoaded event.
        // Fix by calling the cycle method on unitialized carousels where the ride attribute is set. 

        for (let element of document.querySelectorAll("[data-bs-ride=\"carousel\"]")) {

            element = getTarget("Carousel", element);

            if (bootstrap.Carousel.getInstance(element) === null) {
                invoke("Carousel", element, "cycle");
            }
        }

        // Add any other fixes and initializations here.

    }




    function load() {
        
        // Initialize Blazor Bootstrap event handler

        if (!bootstrap) throw new Error("BlazorWerks failed to start. Bootstrap javascript not found.");

        if (!Blazor) throw new Error("BlazorWerks failed to start. Blazor framework javascript not found.")

        if (Blazor && typeof Blazor.registerCustomEventType === 'function') {

            events().forEach(event =>  document.addEventListener(event, eventProxy) );

            Blazor.registerCustomEventType(NET_HANDLER, {
                browserEventName: PROXY_EVENT,
                createEventArgs: e => {
                    return e.detail || e;
                }
            });
        }
        else if (window.console) window.console.warn("BlazorWerks Bootstrap events requires .NET 6.0 or later.");

        
    }


    if (document.readyState === 'loading') document.addEventListener("DOMContentLoaded", load);
    else load();


    return {
        initialize: initialize,
        props: getProps,
        names: names,
        methods: methods,
        events: events,
        invoke: invoke
    }

})();


(window.BlazorWerks || (window.BlazorWerks = {})).WebStorage = (function () {

    // Let .NET access native storage via wrapper object rather than directly

    function StorageWrapper(base) {
        return {
            getItem: function (key) {
                return base.getItem(key);
            },
            setItem: function (key, value) {
                base.setItem(key, value);
            },
            removeItem: function(key) {
                base.removeItem(key);
            },
            clear: function () {
                base.clear();
            },
            key: function (index) {
                return base.key(index);
            },
            length: function () {
                return base.length;
            },
            keys: function () {
                let k = [];
                for (let i = 0; i < base.length; i++) {
                    k.push(base.key(i));
                }
                return k;
            }
        }
    }
    
    function load() {

        // Initialize Blazor storage event handler
        // Note: These events are sent to other pages open on the same domain and
        // not to the page that triggers a storage event.

        if (Blazor && typeof Blazor.registerCustomEventType === 'function') {

            Blazor.registerCustomEventType("storage", {
                browserEventName: "storage",
                createEventArgs: e => {
                    return {
                        // event properties
                        isTrusted: e.isTrusted,
                        eventType: e.type,
                        timeStamp: e.timeStamp,
                        // storage properties
                        key: e.key,
                        newValue: e.newValue,
                        oldValue: e.oldValue,
                        url: e.url,
                        storageArea: e.storageArea === window.sessionStorage ? "sessionStorage" : "localStorage"
                    };
                }
            });

        }
        else warn("StorageEvent handler requires .NET 6.0 or later.");
    }

    if (document.readyState === 'loading') document.addEventListener("DOMContentLoaded", load);
    else load();

    return {
        localStorage: new StorageWrapper(window.localStorage),
        sessionStorage: new StorageWrapper(window.sessionStorage)
    }

})();

