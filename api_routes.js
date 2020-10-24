const express = require("express");
const fbadmin = require("firebase-admin");

const getInfoByUserId = require("./database_funcs/getInfoByUserId");

var router = express.Router();


router.get("/getInfoByUserId", (req, res) => {
    var userID = req.query.userID;
    getInfoByUserId(userID, (userInfo) => {
        res.json(userInfo);
    });
});





module.exports = router;