document.addEventListener('DOMContentLoaded', initilizePage);

function initilizePage() {
    CheckDate();
}

function CheckDate() {
    document.querySelectorAll('.time-button').forEach((element) => {
        let time = new Date();
        let today = new Date();
        time.setHours(element.textContent.substr(0, 2));
        time.setMinutes(element.textContent.substr(element.textContent.length - 2, 2));
        if (time.getTime() < today.getTime()) {
            element.classList.add('disabled-button');
            element.classList.remove('sht-but');
            document.querySelectorAll('.disabled-button').forEach((element) => {
                let link = element.parentElement;
                link.classList.add('disabled-link');

            })
        }
    })
}