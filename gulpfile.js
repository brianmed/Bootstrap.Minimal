var gulp = require('gulp'); 
    gulp.task('copy', function () { 
        gulp.src('./node_modules/bootstrap/dist/**')
            .pipe(gulp.dest('./wwwroot/vendor/bootstrap'));

        gulp.src('./node_modules/jquery/dist/**')
            .pipe(gulp.dest('./wwwroot/vendor/jquery'));
});
