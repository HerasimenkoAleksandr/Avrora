// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener("DOMContentLoaded", () => {
    const cards = document.querySelectorAll('.card-slider .card');
    let currentIndex = 0;

    function showCard(index) {
        cards.forEach(card => card.classList.remove('active'));
        cards[index].classList.add('active');
    }

   
    const nextBtn = document.querySelector('.next-btn');
    if (nextBtn) {
        nextBtn.addEventListener('click', () => {
            currentIndex = (currentIndex + 2) % cards.length;
            showCard(currentIndex);
        });
    }
    const prevBtn = document.querySelector('.prev-btn');
    if (prevBtn) {
        prevBtn.addEventListener('click', () => {
            currentIndex = (currentIndex - 2 + cards.length) % cards.length;
            showCard(currentIndex);
        });
    };

    
    const brandSelect = document.getElementById("carBrandSelect");

    if (brandSelect) {
        fetch('/data/car-brands.json')
            .then(response => response.json())
            .then(data => {
                data.forEach(item => {
                    const option = document.createElement("option");
                    option.value = item.name;
                    option.textContent = item.name;
                    brandSelect.appendChild(option);
                });
            })
            .catch(err => console.error("Ошибка загрузки списка марок:", err));
    }
   
    updateDate(); // первый запуск при открытии страницы
    setInterval(updateDate, 60000); // обновление каждую минуту
});

function updateDate() {
    const now = new Date();

    const day = now.getDate().toString().padStart(2, '0');
    const month = (now.getMonth() + 1).toString().padStart(2, '0');
    const year = now.getFullYear();

    const time = now.toLocaleTimeString("uk-UA", {
        hour: "2-digit",
        minute: "2-digit"
    });

    const element = document.getElementById("wash-title-time");
    if (element) {


        element.innerHTML = `<h3 class="ms-4 navbar-brand logo text-white"> ${time}</h3>`;

    }
};