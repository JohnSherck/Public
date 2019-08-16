document.addEventListener("DOMContentLoaded", initilizePage);
function initilizePage() {
    let remainingTickets = document.querySelector('#remaining-tickets');
    let intRemainingTickets = parseInt(remainingTickets.innerHTML);
    const remainingTicketsInitial = parseInt(remainingTickets.innerHTML);
    let adultElement = document.querySelector('.adult-field');
    let childElement = document.querySelector('.children-field');
    let seniorElement = document.querySelector('.senior-field');



    adultElement.addEventListener('change', (event) => {

        Total();
        console.log(remainingTicketsInitial);
    });

    childElement.addEventListener('change', (event) => {

        Total();
    })

    seniorElement.addEventListener('change', (event) => {
        Total();
    })

    function Total() {
        let intSenior = parseInt(seniorElement.value);
        let intChild = parseInt(childElement.value);
        let intAdult = parseInt(adultElement.value);
        if (intRemainingTickets >= 0) {
            intRemainingTickets = remainingTicketsInitial - intSenior - intChild - intAdult;
            remainingTickets.textContent = intRemainingTickets;
        }
    }
}