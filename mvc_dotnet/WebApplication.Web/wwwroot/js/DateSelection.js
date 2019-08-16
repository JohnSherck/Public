document.addEventListener('DOMContentLoaded', initilizePage);

function initilizePage() {
    let previousDay = document.querySelector('#last-day');
    let nextDay = document.querySelector('#next-day');
    let date = document.querySelector('#current-date');
    let minDate = new Date(date.textContent);
    minDate.setDate(minDate.getDate());
    let maxDate = new Date(date.textContent);
    maxDate.setDate(maxDate.getDate() + 6)
    let today = new Date();
    let startDates = document.querySelectorAll('.start-date');
    let endDates = document.querySelectorAll('.end-date');  
    let films = document.querySelectorAll('.film-card')
    
    CheckDate(); 
    CheckShowing(new Date() );   

    //Determine of the user is viewing a future day, or today  
    function CheckDate() {
        //Future days have NO disabled showtimes, since they're all future showtimes
        if (new Date(date.textContent).getDate() !== today.getDate()) {
            document.querySelectorAll('.time-button').forEach((element) => {
                element.classList.add('sht-but');
                element.classList.remove('disabled-button');
            })
        }
        //if viewing today
        else {
            document.querySelectorAll('.time-button').forEach((element) => {
                let time = new Date();
                time.setHours(element.textContent.substr(0, 2));
                time.setMinutes(element.textContent.substr(element.textContent.length - 2, 2));
                
                //Disable any showtimes that are in the past, you can't reserve seats for a 10AM showing when it's already 3PM.
                if (time.getTime() < today.getTime()) {
                    element.classList.add('disabled-button');
                    element.classList.remove('sht-but');
                }
            })
        }
    }

    //Change the date that is currently displaying
    previousDay.addEventListener('click', (event) => {
        if (new Date(date.textContent).getTime() > minDate.getTime()) {
            let resultDate = addDays(date.textContent, -1);
            date.textContent = resultDate.toLocaleDateString();
            CheckDate();
        }
    })

    //Change the date that is currently displaying
    nextDay.addEventListener('click', (event) => {
        if (new Date(date.textContent).getTime() <= maxDate.getTime()) {
            let resultDate = addDays(date.textContent, 1);
            date.textContent = resultDate.toLocaleDateString();
            CheckDate();
        }
    })

    //Change a date by a given amount
    function addDays(date, amount) {
        var result = new Date(date);
        result.setDate(result.getDate() + amount);

        CheckShowing(result);       //check if viewing today (disable some showtimes)
        //CheckFilmDates(result);     //check the date to determine which movies to show or hide
        return result;
    }

    //Check a given date, only display movies that will play on that date
    function CheckShowing(result) {
        
        films.forEach(film => {
            let startDateString = film.querySelector('.start-date').value;
            let endDateString = film.querySelector('.end-date').value;
            let filmStartDate = new Date(startDateString.slice(0, startDateString.length - 12));
            let filmEndDate = new Date(endDateString.slice(0, endDateString.length - 12));

            let today = new Date();
            let finalDay = new Date();  //the last date the user is allowed to view
            finalDay.setDate(today.getDate() + 6);            
            let viewDate = result;      //the date the user is currently viewing

            console.log(viewDate);
            if (filmStartDate <= viewDate && filmEndDate > viewDate){
                film.classList.remove('hidden')
            }
            else{
                film.classList.add('hidden');
            }

        });
    }    
}