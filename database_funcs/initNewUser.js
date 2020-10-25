const fbadmin = require("firebase-admin");

module.exports = function(userID, name, advanced, callback) {

    var coll = fbadmin.firestore().collection("users");

    coll.doc().set({
        userID,
        name,
        balance: 0,
        advanced,
        inGameMoney: 0
    });

}