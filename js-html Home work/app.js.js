let database = [];

const form = document.getElementById("registrationForm");
const fnameInput = document.getElementById("fname");
const lnameInput = document.getElementById("lname");
const ageInput = document.getElementById("age");
const passwordInput = document.getElementById("password");
const emailInput = document.getElementById("email");
const genderInput = document.getElementById("gender");
const hobbiesInput = document.getElementById("hobbies");
const cleanButton = document.getElementById("clean");

form.addEventListener("submit", function (e) {
    e.preventDefault();

    if (parseInt(ageInput.value) < 18) {
        alert("Yaşı 18-dən böyük olmalıdır!");
        return;
    }

    if (fnameInput.value.length < 3 || lnameInput.value.length < 3) {
        alert("Ad və Soyad ən az 3 hərfdən ibarət olmalıdır!");
        return;
    }

    const newUser = {
        Fname: fnameInput.value,
        Lname: lnameInput.value,
        Age: parseInt(ageInput.value),
        Password: passwordInput.value,
        Email: emailInput.value,
        Gender: genderInput.value,
        Hobbilər: hobbiesInput.value,
    };

    database.push(newUser);

    form.reset();

    logDatabase();
});

cleanButton.addEventListener("click", function () {
    form.reset();
});

function logDatabase() {
    console.log(database);
}

function logAdlar() {
    for (const user of database) {
        console.log(user.Fname);
    }
}

function logAdSoyad() {
    for (const user of database) {
        console.log(user.Fname + " " + user.Lname);
    }
}

function tekVeyaCütTəyinEt(ədəd) {
  if (ədəd % 2 === 0) {
    return "cüt";
  } else {
    return "Tək";
  }
}

// meselen:
var n = 7; //istediyin ededi yaza bilersen
var netice = tekVeyaCütTəyinEt(n);
console.log(7 + " " + netice + " ədəddir.");
function hesabla(ədəd1, ədəd2, əməliyyat) {
  if (əməliyyat === 'toplama') {
    return ədəd1 + ədəd2;
  } else if (əməliyyat === 'çıxma') {
    return ədəd1 - ədəd2;
  } else if (əməliyyat === 'vurma') {
    return ədəd1 * ədəd2;
  } else if (əməliyyat === 'bölmə') {
    if (ədəd2 === 0) {
      return "Sıfıra bölünmə yalnışdır!";
    } else {
      return ədəd1 / ədəd2;
    }
  } else {
    return "Yanlış əməliyyat!";
  }
}

// meselen
var ədəd1 = 10;
var ədəd2 = 5;
var əməliyyat = 'toplama';

var cavab = hesabla(ədəd1, ədəd2, əməliyyat);
console.log(ədəd1 + ' və ' + ədəd2 + ' arasında ' + əməliyyat + ' edildi: ' + cavab);
//meselen 
var ədəd1 = 10;
var ədəd2 = 5;
var əməliyyat = 'vurma';

let cavab = hesabla(ədəd1, ədəd2, əməliyyat);
console.log(ədəd1 + ' və ' + ədəd2 + ' arasında ' + əməliyyat + ' edildi: ' + cavab);

