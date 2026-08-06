const CACHE = "v1";

self.addEventListener("install", event => {

    console.log("Service Worker Installed");

    event.waitUntil(
        caches.open(CACHE).then(cache => {
            return cache.addAll([
                "/",
                "/index.html"
            ]);
        })
    );
});

self.addEventListener("fetch", event => {

    event.respondWith(
        fetch(event.request)
            .catch(() => caches.match("/index.html"))
    );

});
