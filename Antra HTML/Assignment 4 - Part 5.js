const styles = ["James", "Brennie"];
console.log(styles);

styles.push("Robert");
console.log(styles);

styles.splice((styles.length/2), 1, "Calvin");
console.log(styles);

styles.shift();
console.log(styles);

styles.unshift("Rose", "Regal");
console.log(styles);
