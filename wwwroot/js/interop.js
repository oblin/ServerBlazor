function createAlert() {
    alert("This is an alert");
}

function createPrompt(question) {
    return prompt(question);
}

function setElementById(id, text) {
    document.getElementById(id).innerText = text;
}

function focusOnElement(element) {
    element.focus();
}

function randomInt(maxValue) {
    DotNet.invokeMethodAsync("ServerBlazor", "GenerateRandomInt", maxValue)
        .then(result => {
            setElementById("spanRandom", result);
        });
}

function randomIntByObject(maxValue, dotnetInstance) {
    dotnetInstance.invokeMethodAsync("Generate", maxValue)
        .then(result => {
            setElementById("spanRandom", result);
        });
}