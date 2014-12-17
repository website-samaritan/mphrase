module.exports = function (grunt) {

	grunt.initConfig({
		jshint: {
			files: ['Gruntfile.js', 'assets/**/*.js', 'test/**/*.js'],
			options: {
				globals: {
					
				}
			}
		},
		watch: {
			files: ['<%= jshint.files %>'],
			tasks: ['jshint']
		}
	});

	grunt.loadNpmTasks('grunt-contrib-jshint');
	grunt.loadNpmTasks('grunt-contrib-watch');

	grunt.registerTask('default', ['jshint']);

};