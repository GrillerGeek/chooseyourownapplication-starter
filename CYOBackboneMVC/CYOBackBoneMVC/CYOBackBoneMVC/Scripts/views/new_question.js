App.Views.NewQuestion = Backbone.View.extend({

    initialize: function (options) {
        App.currentUser.on("change", this.render, this);
        this.render();
    },

    render: function () {
        this.$el.toggleClass("hidden", !App.currentUser.isLoggedIn());
        this.$("#asker").text(App.currentUser.get("userName"));
        return this;
    }

});