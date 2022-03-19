

(window.BlazorTools || (window.BlazorTools = {})).Bootstrap = (function () {

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

    function props(name) {

        if (typeof name === "string") {
            let i = propList.map(function (p) { return p.name.toLowerCase(); }).indexOf(name.toLocaleLowerCase());
            return i < 0 ? undefined : propList[i];
        }
        return propList;
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


    // invokes a bootstrap component method

    function invoke(name, target, options, method, ...args) {

        debug(`Invoking Bootstrap method ${name}.${method}()`);

        let item = props(name);

        if (typeof target === "string") target = document.querySelector(target);

        target = target.matches(item.selector) ? target : target.querySelector(item.selector);

        let instance = bootstrap[item.name].getOrCreateInstance(target, options);

        if (typeof method === "string") instance[method](args);
    }


    function load() {
        
        // Initialize Blazor Bootstrap event handler

        if (Blazor && typeof Blazor.registerCustomEventType === 'function') {

            debug(`Adding .NET event handler ${NET_HANDLER} for Bootstrap events:`, events());

            events().forEach(event =>  document.addEventListener(event, eventProxy) );

            Blazor.registerCustomEventType(NET_HANDLER, {
                browserEventName: PROXY_EVENT,
                createEventArgs: e => {
                    return e.detail || e;
                }
            });

        }
        else warn("Bootstrap event handler requires .NET 6.0 or later.");
    }

    function warn(...args) {
        if (window.console && window.console.warn) window.console.warn(args);
    }

    function debug(...args) {
        if (DEBUG && window.console && window.console.info) window.console.info(args);
    }


    if (document.readyState === 'loading') document.addEventListener("DOMContentLoaded", load);
    else load();


    return {
        props: props,
        names: names,
        methods: methods,
        events: events,
        invoke: invoke
    }

})();


(window.BlazorTools || (window.BlazorTools = {})).WebStorage = (function () {

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

