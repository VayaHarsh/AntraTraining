let salaries = {John: 100, Ann: 160, Pete: 130}

var sum = 0;
for (var i in salaries) {
    sum += salaries[i];
}

console.log(sum);

