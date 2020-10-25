const express = require("express");
const fbadmin = require("firebase-admin");

const getInfoByUserId = require("./database_funcs/getInfoByUserId");
const depositMoney = require("./database_funcs/depositMoney");
const initNewUser = require("./database_funcs/initNewUser");

var router = express.Router();


router.get("/getInfoByUserId", checkLoggedIn, (req, res) => {
    //var userID = req.query.userID;
    getInfoByUserId(req.loggedInUser.uid, (userInfo) => {
        res.json(userInfo);
    });
});

router.get("/depositMoney", checkLoggedIn, (req, res) => {
    depositMoney(req.loggedInUser.uid, req.query.amount, () => {
        res.json({"success": true});
    });
});

router.get("/initNewUser", (req, res) => {
    var userID = req.query.userID;
    var advancedBool = req.query.advanced == "true";
    var name = req.query.name;
    initNewUser(userID, name, advancedBool, () => {
        res.json({success: true});
    });
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