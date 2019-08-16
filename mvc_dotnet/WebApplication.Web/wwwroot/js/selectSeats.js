document.addEventListener('DOMContentLoaded', initializePage);
let closedSeats = [];
let chosenSeats = [];
let maxSeats;

function initializePage() {
    let table = document.querySelector("table");
    generateTable(table);

}

//Add or remove a seat from ChosenSeats
function toggleSeat(event){
    let seatNum = parseInt(event.target.value);    
    
    if(!chosenSeats.includes(seatNum)){
        if(chosenSeats.length < maxSeats){//if have not selected your allowance of seats
            chosenSeats.push(seatNum);  //add to array
            event.target.classList.add("selectedSeat");
        }
        
    }

    //Deselect the seat
    else{
        chosenSeats.splice(chosenSeats.indexOf(seatNum), 1);//remove seatNum
        event.target.classList.remove("selectedSeat");
    }

    setChosenSeatsInput(chosenSeats);
}

function setClosedSeats(arr){
    closedSeats = arr;    
}

function setChosenSeatsInput(arr){
    let chosenSeatsField = document.getElementById('ChosenSeatsAsString');
    chosenSeatsField.value = JSON.stringify(chosenSeats);
}
function setMaxSeats(max){
    maxSeats = max;
}


function generateTable(table) {
    console.log(closedSeats);

    for (let i = 0; i < 10; i++) {
        let row = document.createElement("tr");
        for (let j = 0; j < 10; j++) {
            let col = document.createElement("td");
            //col.innerHTML = (i * 10) + j + 1; // assigning value to the cell
            
            //create a button to put in the <td>
            let btn = document.createElement('input');
            btn.type = "button";
            btn.className = "btn btn-primary seat";
            btn.value = ((i * 10) + j + 1).toString();
            let seatNumber = parseInt(`${i}${j+1}`);
            
            //available seat
            if(!closedSeats.includes(seatNumber)){
                btn.onclick = toggleSeat;
            }

            //reserved seat
            else{
                btn.setAttribute("disabled", "true");
                btn.classList.add("reservedSeat");
            }

            //either way, add it to the DOM
            col.appendChild(btn);
            row.appendChild(col);
            
        }
        table.appendChild(row);
    }
}