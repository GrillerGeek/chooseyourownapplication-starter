App.Collections.Questions = Backbone.Collection.extend({
    model: App.Models.Question,
    signalRHub: new Backbone.SignalR("questionHub"),
    
    initialize: function () {
        this.signalRHub.syncUpdates(this);
    }
});