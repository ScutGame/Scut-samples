/**
 * View class.
 */
var View ={
	/**
	 * init view.
	 */
	ctor: function() {
		var view = this;
		//reg action event.
		Scut.Action.events.add(1004, function(data){
			Scut.Net.Params.bind(data.UserId || 0, data.SessionId || '');
			//debug
			cc.log('goto chat scene.');
			cc.Director.getInstance().replaceScene(new ChatScene());
		});

		Scut.Action.events.add(3002, function(data){
			view.bindChatScene( data);
		});
	},
	/**
	 * bind scene data.
	 * @param {String} target
	 * @param {Object} data
	 */
	bindChatScene: function(data) {
		var scene = cc.director.getRunningScene();
		//var layer = scene.children[scene.childrenCount-1];
		var chatLayer = scene.getChildByName('ChatLayer')
		
		//debug
		cc.log('Chat json:'+ Scut.Utils.serializeJson(data));
		if(!chatLayer){
			cc.log('Chat bind scene data error.');
			return;
		}
		chatLayer.renderChat(data);
	}
};

