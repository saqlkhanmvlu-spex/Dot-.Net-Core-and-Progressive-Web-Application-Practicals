self.addEventListener("Install", e => {
    console.log("Service Worker Installed");
});

self.addEventListener("fetch", e => {
    e.responseWith(fetch(e.request));
});
