const fbadmin = require("firebase-admin");

module.exports = function(userID, callback) {

    var coll = fbadmin.firestore().collection("users");

    var userInfo = {};

    coll.where("userID", "==", userID)
        .get()
        .then(snapshot => {
            snapshot.forEach(doc => {
                userInfo = doc.data();
            });
            callback(userInfo);
        })
        .catch(err => console.log(`Error getting documents: ${err}`));

}