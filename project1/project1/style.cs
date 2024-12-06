/*General body styling */
body {
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    background-color: rgb(242, 245, 245);
    color: rgba(24, 23, 23, 0.938);
    margin: 0%;
    padding: 0%
}

/* Header styling */
header {
    background-color: rgb(252, 250, 249);
    color: rgb(14, 13, 13);
    margin: 0%;
    padding: 0%;
}

/* section styling */
section {
    margin: 5px auto;
    max-width: 850px;
    padding: 5px;
    background-color: rgb(250, 249, 247);
    border-radius: 20px;
    box-shadow: 0 20px 15px rgba(185, 83, 83, 0.1);
}

h1 h2 h3 {
    font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
    color: black;
}

/* Form Section */
form section {
    background-color: rgb(251, 253, 253);
    padding: 20px;
    border-radius: 12px;
}

/* Form group styling */
form-group {
    margin-bottom: 15px;
}

label {
    margin-bottom: 5px;
    font-weight: bold;
}

input[type="text"],
input[type="email"],
input[type="password"],
input[type="number"],
select,
textarea {
    width: 100%;
    padding: 10px;
    border: 1px solid #111111;
    border-radius: 4px;
    box-sizing: border-box;
}

input[type="radio"] {
    margin-right: 5px;
}

input[type="radio"],
label {
    margin-right: 10px;
}

ul li {
    margin-bottom: 5px;
    display:inline-block
}

/* Submit button */
input[type="submit"] {
    background-color: rgb(70, 177, 70);
    color: rgb(15, 7, 7);
    padding: 10px 20px;
    border: none;
    border-radius: 4px;
    cursor: pointer;
}

input[type="submit"]:hover {
    background-color: #090a0a;
}

/* Responsive design */
@media (max-width: 768px) {

    .form-section,
    .table-demo,
    .html-elements-demo,
    .media-demo {
        padding: 15px;
    }

    input[type="text"],
    input[type="email"],
    input[type="password"],
    input[type="number"],
    select,
    textarea {
        width: 100%;
    }
}

p {
    text-align: center;
    color: white;
    background-color: #1b1919;
}

/* table style */
th {
    background-color: #c8ced1;
}