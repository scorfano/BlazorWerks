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

