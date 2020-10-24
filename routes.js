const express = require("express");
const fbadmin = require("firebase-admin");

var router = express.Router();



router.get("/", curiousLoggedIn, (req, res) => {
    if (req.loggedInUser == null) res.render("index.ejs", { loggedIn: req.loggedInUser != null });
    else res.redirect("/home");
});

router.get("/home", checkLoggedIn, (req, res) => {
    res.render("home.ejs")
});






router.post("/sessionLogin", (req, res) => {
    const id = req.body.idToken.toString();
    const csrf = req.body.csrfToken.toString();
    const expiryTime = 60 * 60 * 24 * 5 * 1000;
    fbadmin
        .auth()
        .createSessionCookie(id, { expiresIn: expiryTime })
        .then(
            sessionCookie => {
                res.cookie("session", sessionCookie, {
                    maxAge: expiryTime,
                    httpOnly: true,
                    secure: false,
                });
                res.end(JSON.stringify({ status: "success" }));
            },
            err => {
                res.status(401).send("UNAUTHORISED");
            },
        );
});

router.get("/sessionLogout", (req, res) => {
    res.clearCookie("session");
    res.redirect("/");
});

function curiousLoggedIn(req, res, next) {
    const sessionCookie = req.cookies.session || "";
    fbadmin
        .auth()
        .verifySessionCookie(sessionCookie, true)
        .then(claims => {
            req.loggedInUser = claims;
            next();
        })
        .catch(err => {
            // User needs to login as cookie is invalid
            req.loggedInUser = null;
            next();
        });
}

function checkLoggedIn(req, res, next) {
    const sessionCookie = req.cookies.session || "";
    fbadmin
        .auth()
        .verifySessionCookie(sessionCookie, true)
        .then(claims => {
            req.loggedInUser = claims;
            next();
        })
        .catch(err => {
            // User needs to login as cookie is invalid
            req.loggedInUser = null;
            res.redirect("/");
        });
}

module.exports = router;