mergeInto(LibraryManager.library, {
    Complete: function () {
        completeGame();
    },
    Started: function() {
        gameLoaded();
    },
});