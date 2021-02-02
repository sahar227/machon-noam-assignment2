const statusElement = document.getElementById('status');

const submitForm = (e) => {
    e.preventDefault();
    const formData = new FormData(e.target);
    console.log(formData.get('email'));
}

const changeStatus = (message) => {
    statusElement.innerHTML = message;
}