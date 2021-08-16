function required() {
    var name = document.commentForm.name.value;
    var message = document.commentForm.message.value;
    debugger;
    if (name === "" || message === "") {
        alert("نام و متن کامنت باید پر باشند");
        return false;
    } else {
        return true;
    }
}