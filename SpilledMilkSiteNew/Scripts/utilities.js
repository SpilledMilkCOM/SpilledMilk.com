
// Short hand jQuery of:
//		$(document).ready(function() {
//		});

$(function () {
	$(window).on("load resize", function () {
		$(".fill-screen").css("height", window.innerHeight);
	});

	$(window).on("load resize", function () {
		$(".three-quarter-screen").css("height", window.innerHeight * 0.75);
	});

	$(window).on("load resize", function () {
		$(".half-screen").css("height", window.innerHeight * 0.5);
	});

	// smooth scrolling
	$('nav a, .down-button a').bind('click', function () {
		$('html, body').stop().animate({
			scrollTop: $($(this).attr('href')).offset().top - 50
		}, 1500, 'easeInOutExpo');
		event.preventDefault();
	});

	// parallax scrolling with stellar.js
	$(window).stellar();

	// initialize WOW for element animation
	new WOW().init();

	// Initialize nanoGallery.
	// http://nanogallery.brisbois.fr/
	// Paid $25 to use on this site.
	// New site:  http://nanogallery2.nanostudio.org/
	// https://github.com/nanostudio-org/nanogallery2

	$(document).ready(function () {
		$("#nanoGallery1").nanoGallery(
			{
				thumbnailWidth: 'auto',
				thumbnailHeight: 220,
				locationHash: false,
				thumbnailHoverEffect: 'borderLighter,imageScaleIn80'
			});
	});

	$(document).ready(function () {
		$("#nanoGallery2").nanoGallery(
			{
				thumbnailWidth: 'auto',
				thumbnailHeight: 220,
				locationHash: false,
				thumbnailHoverEffect: 'borderLighter,imageScaleIn80'
			});
	});

	$(document).ready(function () {
		$("#nanoGallery3").nanoGallery(
			{
				thumbnailWidth: 'auto',
				thumbnailHeight: 220,
				locationHash: false,
				thumbnailHoverEffect: 'borderLighter,imageScaleIn80'
			});
	});

	$(document).ready(function () {
		$("#nanoGallery4").nanoGallery(
			{
				thumbnailWidth: 'auto',
				thumbnailHeight: 220,
				locationHash: false,
				thumbnailHoverEffect: 'borderLighter,imageScaleIn80'
			});
	});

	// For Twitter
	!function (d, s, id) {
		var js, fjs = d.getElementsByTagName(s)[0], p = /^http:/.test(d.location) ? 'http' : 'https';
		if (!d.getElementById(id)) {
			js = d.createElement(s);
			js.id = id;
			js.src = p + '://platform.twitter.com/widgets.js';
			fjs.parentNode.insertBefore(js, fjs);
		}
	}(document, 'script', 'twitter-wjs');

	// For Facebook
	!function (d, s, id) {
		var js, fjs = d.getElementsByTagName(s)[0];
		if (d.getElementById(id)) return;
		js = d.createElement(s); js.id = id;
		js.src = "//connect.facebook.net/en_US/sdk.js#xfbml=1&version=v2.3";
		fjs.parentNode.insertBefore(js, fjs);
	}(document, 'script', 'facebook-jssdk');
});