module.exports = function (grunt) {
	'use strict';

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
		},
		sass: {
			dist: {
				options: {
					style: 'expanded'
				},
				files: {
					'web/mphraseWebRole/css/site.css': 'assets/sass/styles.scss'
				}
			}
		}
	});

	grunt.loadNpmTasks('grunt-contrib-jshint');
	grunt.loadNpmTasks('grunt-contrib-watch');
	grunt.loadNpmTasks('grunt-contrib-sass');
	
	grunt.registerTask('default', ['jshint', 'sass']);

};