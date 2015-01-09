/**
 * Net event process.
 */

Scut.Action = {
	events:{
		_items: {},
		/**
		 * @param {number} actionId
		 * @param {function} func 
		 */
		add: function(actionId, func){
			this._items[actionId] = func || function(data) {};
		},
		trigger: function(actionId, param){
			var func = this._items[actionId];
			if(typeof func === "function"){
				return func(param);
			}
			cc.log('Not found trigger action ' + actionId + ' event.');
		}
	},
	/**
	 * reader object.
	 * @param jsonData
	 * @returns {object}
	 */
	createReader: function(jsonData) {
		var _data = jsonData || {};
		return {
			getSuccess: function(){
				return _data.ErrorCode === 0 || false;
			},
			getAction: function(){
				return _data.ActionId || 0;
			},
			getData: function(){
				return _data.Data;
			}
		};
	},
	/**
	 * receive message.
	 * @param jsonData
	 */
	receive: function (jsonData){
		var rd = Scut.Action.createReader(jsonData);
		var result = rd.getSuccess();
		if(!result){
			cc.log('receive error source:'+ Scut.Utils.serializeJson(jsonData));
			return;
		}
		var actionId = rd.getAction();
		Scut.Action.events.trigger(actionId, rd.getData());
	},
	/**
	 * close process.
	 */
	close: function (){
		//do reset connect
	},
	/**
	 * error process.
	 */
	error: function (){
		//do error
	}
};
