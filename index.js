const express = require("express");
const cookieParser = require("cookie-parser");

var app = express();

// Body parser
app.use(express.json());
app.use(express.urlencoded({ extended: true }));

// Cookie parser
app.use(cookieParser());

app.set("view engine", "ejs");


app.use(express.static("static"));

// Routes
app.use("/", require("./routes.js"));



app.listen(process.env.PORT || 5000, () => {
    console.log(`Listening on port ${process.env.PORT || 5000}`);
});