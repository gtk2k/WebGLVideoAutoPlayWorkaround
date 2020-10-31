mergeInto(LibraryManager.library, {
    workaround: function() {
        console.log('Setup workaround.');
        var workaroundAudio = new Audio();
        workaroundAudio.src = 'silent.mp3';
        document.body.appendChild(workaroundAudio);
        var canvas = document.getElementById('unity-canvas');
        if(canvas) {
            console.log('canvas found');
            canvas.addEventListener('click', function() {
                workaroundAudio.play();
            });
        }
    }
});