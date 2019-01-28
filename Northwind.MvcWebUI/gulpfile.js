const gulp = require('gulp');
const concat = require('gulp-concat');

const vendorStyle = [
    "node_modules/bootstrap/dist/css/bootstrap.min.css",
];

const vendorScripts = [
    "node_modules/jquery/dist/jquery.min.js",
    "node_modules/popper.js/dist/umd/popper.min.js",
    "node_modules/bootstrap/dist/js/bootstrap.min.js",
];

gulp.task('default', ['build-vendor']);
gulp.task('build-vendor', ['build-css', 'build-js']);

gulp.task('build-css', () => {
    return gulp.src(vendorStyle)
        .pipe(concat('main.min.css'))
        .pipe(gulp.dest('wwwroot/css'));
});

gulp.task('build-js', () => {
    return gulp.src(vendorScripts)
        .pipe(concat('main.min.js'))
        .pipe(gulp.dest('wwwroot/js'));
});