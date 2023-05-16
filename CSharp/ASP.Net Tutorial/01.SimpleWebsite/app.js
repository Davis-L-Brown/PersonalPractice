/// document.query selector uses css selectors
/// switcher becomes a reference to the css selector .btn
const switcher = document.querySelector('.btn');

switcher.addEventListener('click', function () {
    document.body.classList.toggle('light-theme');
    document.body.classList.toggle('dark-theme');
});