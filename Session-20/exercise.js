function ReverseInput(e){
    let input = document.querySelector('#txtInput');
    input.value = ReverseString(input.value);
}

function ReverseString(input){
    return input.split('').reverse().join('');
}

function IsPalindrome(e){
    let value = document.querySelector('#txtInput').value;
    let reversed = ReverseString(value);
    if(value === reversed) {
        alert(`It is Palindrome!!\nOriginal: ${value}\nReversed: ${reversed}`);
        return;
    }
    
    alert(`It is NOT a palindrome!!\nOriginal: ${value}\nReversed: ${reversed}`);
}

function ParseFormData(e){
    let name = document.querySelector('#txtName').value;
    let surname = document.querySelector('#txtSurname').value;
    let age = document.querySelector('#txtAge').value;
    let gender = document.querySelector('input[name="Gender"]:checked').value;
    
    InsertToTable(Capitalize(name), Capitalize(surname), age, gender);
}

function Capitalize(s){
    return s.charAt(0).toUpperCase() + s.slice(1).toLowerCase();
}

function InsertToTable(name, surname, age, gender){
    let table = document.querySelector('#customerTable');
    let tr = document.createElement('tr');
    let nametd = document.createElement('td');
    nametd.innerHTML = name;
    tr.appendChild(nametd);
    let surnametd = document.createElement('td');
    surnametd.innerHTML = surname;
    tr.appendChild(surnametd);
    let agetd = document.createElement('td');
    agetd.innerHTML = age;
    tr.appendChild(agetd);
    let gendertd = document.createElement('td');
    gendertd.innerHTML = gender;
    tr.appendChild(gendertd);
    tr.addEventListener('click', SelectedRow);
    table.appendChild(tr);
}

function SelectedRow(e){
    document.querySelector('#txtNameDetails').value = this.children[0].innerText;
    document.querySelector('#txtSurnameDetails').value = this.children[1].innerText;
    document.querySelector('#txtAgeDetails').value = this.children[2].innerText;
    document.querySelector('#txtGenderDetails').value = this.children[3].innerText;
}

function IncrementString(){
    let input = document.querySelector('#txtInput').value;
    if(!Number.parseInt(input[input.length-1]) && Number.parseInt(input[input.length-1]) !== 0){
        document.querySelector('#txtInput').value = input+'1';
        return;
    }

    let index = -1;
    for(i=input.length-1;i>=0;i--){
        if(Number.parseInt(input[i]) || Number.parseInt(input[i]) === 0){
            index = i;
        }else{
            break;
        }
    }

    if(index >= 0){
        document.querySelector('#txtInput').value = input.slice(0, index) + (+input.slice(index) + 1);
        return;
    }

    console.log(matched);
}