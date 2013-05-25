
/*3.Refactor the following examples to produce code with well-named identifiers in JavaScript*/

function buttonOnClick(event, arguments) {
    var customWindow = window;
    var browser = customWindow.navigator.appCodeName;
    var isMozilla = browser == "Mozilla";
    if (isMozilla) {
        alert("Yes");
    }
    else {
        alert("No");
    }
}
