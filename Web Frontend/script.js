const statusElement = document.getElementById('status');
const password = document.getElementById("password")
const confirm_password = document.getElementById("confirm_password");

const endpointAddress = 'http://localhost:52308/auth'
const submitForm = async (e) => {
    e.preventDefault();
    if(!validatePassword())
        return;
    const formData = new FormData(e.target);
    const response = await sendRequest({
        email: formData.get('email'),
        password: formData.get('password'),
        repeatedPassword: formData.get('confirm_password')
    });


    console.log(response);
}

const changeStatus = (message) => {
    statusElement.innerHTML = message;
}

// validate password confirmation matches password
const validatePassword = () =>{
    if(password.value != confirm_password.value) {
      confirm_password.setCustomValidity("Passwords Don't Match");
      return false;
    }
    confirm_password.setCustomValidity('');
    return true;
  }

  const sendRequest = async (request) => {
    const response = await fetch(endpointAddress, {
        method: 'POST',
        headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
        },
        body: JSON.stringify(request)
    });
    return response;
  }