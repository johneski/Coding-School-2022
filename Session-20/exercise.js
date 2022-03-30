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