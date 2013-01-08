/// <reference path="../jquery-1.7.2.intellisense.js" />
/// <reference path="../backbone.js" />

App.Models.User = Backbone.Model.extend({
    logIn: function (userName) {
        if (!userName) return;
        this.set("userName", userName);
    },
    
    isLoggedIn: function () {
        return this.has('userName');
    },
});