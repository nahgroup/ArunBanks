const express = require("express");
const cookieParser = require("cookie-parser");
require("firebase/auth");
const fbadmin = require("firebase-admin");

const fbServiceAccountKey = require("./config/firebase_service_account_key.json");

// Firebase
fbadmin.initializeApp({
    credential: fbadmin.credential.cert(fbServiceAccountKey),
    databaseURL: "https://arunbanks-1b06b.firebaseio.com",
});

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

app.use("/api", require("./api_routes.js"));



app.listen(process.env.PORT || 5000, () => {
    console.log(`Listening on port ${process.env.PORT || 5000}`);
});