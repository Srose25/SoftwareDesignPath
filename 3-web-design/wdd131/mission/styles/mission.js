console.log("Mission.js is connected!");

// Select the dropdown and the body
const themeSelector = document.getElementById('theme');
const body = document.querySelector('body');
const logo = document.querySelector('.logo');


themeSelector.addEventListener('change', changeTheme);

function changeTheme() {
  const selected = themeSelector.value;
  if (selected === 'dark') {
    body.classList.add('dark');
    logo.src = 'images/byui-logo_white.png';
  } else {
    body.classList.remove('dark');
    logo.src = 'images/logo.webp';
  }
}
