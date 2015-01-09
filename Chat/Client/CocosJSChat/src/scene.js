
var LoginLayer = cc.Layer.extend({
    sprite:null,
    nameField:null,

    textFieldEvent: function (sender, type) {
    	
    },
    ctor:function () {
    	this._super();
    	var parent = this;
        var size = cc.winSize;

        this.sprite = new cc.Sprite(res.BG_png);
        this.sprite.attr({
        	x: size.width / 2,
        	y: size.height / 2,
        	scale: 1.8,
        	rotation: 0
        });
        this.addChild(this.sprite, 0);
        
        var nameLabel = new cc.LabelTTF("昵称:", "Arial", 38);
        nameLabel.x = 100;
        nameLabel.y = size.height / 2 + 40;
        this.addChild(nameLabel);
        
        var normal9SpriteBg=new cc.Scale9Sprite(res.text_png);
        var press9SpriteBg=new cc.Scale9Sprite(res.text_png);
        var disabled9SpriteBg=new cc.Scale9Sprite(res.text_png);
        
        //init text
        this.nameField = new ccui.TextField();
        this.nameField.setTouchEnabled(true);
        this.nameField.setMaxLengthEnabled(true);
        this.nameField.setMaxLength(16);
        this.nameField.setPlaceHolder( "Click here for input");
        this.nameField.attr({
        	fontName : "Arial",
        	fontSize: 30,
        	alignment:cc.TEXT_ALIGNMENT_LEFT,
        	width:200,
        	x: 150,
        	y: size.height / 2 + 40,
        	anchorX: 0,
        	anchorY: 0.5
        });
        this.nameField.addEventListener(this.textFieldEvent, this);
        this.addChild(this.nameField);
        
        var btnItem = new cc.MenuItemLabel(cc.LabelTTF("Login", "Arial", 38),
        	function(){
        		var name = parent.nameField.getString();
        		cc.log(name + " is loginningt..");
        		Scut.Net.Instance().send(Scut.Net.Params.extend({ActionId:1004, UserName:name}));
        	}, 
        	this);
        /*
         * cc.color.WHITE;//白色
         * cc.color.YELLOW;//黄色
         * cc.color.BLUE;//蓝色
         * cc.color.GREEN;//绿色
         * cc.color.RED;//红色
         * cc.color.MAGENTA;//紫红色
         * cc.color.BLACK;//黑色
         * cc.color.ORANGE;//橙色
         * cc.color.GRAY;//灰色
         */
        var btnColor = cc.color.ORANGE;
        btnItem.setColor(btnColor);
        
        var menu = new cc.Menu(btnItem);
        menu.x = size.width-80;
        menu.y = 40;
        this.addChild(menu);
        
        /* //手
        var shou_spr=new cc.Sprite(res.shou_png);
		shou_spr.attr({
			x: size.width/2,
			y: size.height-80,
			anchorX: 0.5,
			anchorY: 0.5,
			zindex: 100
		});
		shou_spr.setVisible(false);
        this.addChild(shou_spr)
		//滑动侦听
		var listener=cc.EventListener.create({
			event: cc.EventListener.TOUCH_ONE_BY_ONE,
			swallowTouches: true,
			onTouchBegan: function (touch, event) {
				//do something
				shou_spr.setVisible(true);
				var pos = touch.getLocation();
				shou_spr.x = pos.x;
				shou_spr.y = pos.y;
				return true;
			},
			onTouchEnded:function(touch,event){
				shou_spr.setVisible(false);
			}
		});
		
		cc.eventManager.addListener(listener, shou_spr)
		*/
       
        return true;
    }
});

var LoginScene = cc.Scene.extend({
    onEnter:function () {
        this._super();
        var layer = new LoginLayer();
        this.addChild(layer);
    }
});

var ChatLayer = cc.Layer.extend({
	sprite: null,
	messageField: null,
	listView: null,
	textFieldEvent: function (sender, type) {

	},
	selectedItemEvent: function (sender, type) {
	
	},
	ctor:function () {
		this._super();
		var parent = this;
		var size = cc.winSize;

		this.sprite = new cc.Sprite(res.BG_png);
		this.sprite.attr({
			x: size.width / 2,
			y: size.height / 2,
			scale: 1.8,
			rotation: 0
		});
		this.addChild(this.sprite);

		var closeItem = new cc.MenuItemImage(
			res.CloseNormal_png,
			res.CloseSelected_png,
			function () {
				Scut.Net.reset();
				Scut.Net.connect();
				cc.Director.getInstance().replaceScene(new LoginScene());
			}, this);
		closeItem.attr({
			x: size.width - 20,
			y: 20,
			anchorX: 0.5,
			anchorY: 0.5
		});

		var menu = new cc.Menu(closeItem);
		menu.x = 0;
		menu.y = size.height - 40;
		this.addChild(menu);

		var titleLabel = new cc.LabelTTF("聊天室", "Arial", 38);
		titleLabel.x = size.width / 2;
		titleLabel.y = size.height- 20;
		this.addChild(titleLabel);
		
		
		var sendBg = new cc.Sprite(res.ChatBg_png, cc.rect(0,0,size.width-50,30));
		sendBg.attr({
			x: 2,
			y: 5,
			scale: 1,
			rotation: 0,
			anchorX: 0,
			anchorY: 0
		});
		this.addChild(sendBg);

		var default_item = new ccui.Layout();
		default_item.setTouchEnabled(true);
		default_item.width = size.width-50;
		
		this.messageField = new ccui.TextField();
		this.messageField.setTouchEnabled(true);
		this.messageField.setMaxLengthEnabled(true);
		this.messageField.setMaxLength(40);
		this.messageField.setPlaceHolder( "Input message here");
		default_item.setContentSize(size.width-50, this.messageField.getContentSize().height);
		
		this.messageField.attr({
			fontName : "Arial",
			fontSize: 30,
			alignment:cc.TEXT_ALIGNMENT_LEFT,
			width:size.width-50,
			x: 5,
			y: 20,
			anchorX: 0,
			anchorY: 0.5
		});
		this.messageField.addEventListener(this.textFieldEvent, this);
		default_item.addChild(this.messageField);
		this.addChild(default_item)

		var btnSend = new cc.MenuItemImage(
			res.SendNormal_png,
			res.SendSelected_png,
			function() {
				var msg = parent.messageField.getString();
				parent.messageField.setString('');
				cc.log('Send chat:' +msg);
				if(!msg || msg.length === 0){
					return;
				}
				Scut.Net.Instance().send(Scut.Net.Params.extend({ActionId:3001,message: msg}));
			}, this);
		btnSend.attr({
			x: size.width - 20,
			y: 20,
			anchorX: 0.5,
			anchorY: 0.5
		});
		var sendMenu = new cc.Menu(btnSend);
		sendMenu.x = 0;
		sendMenu.y = 0;
		this.addChild(sendMenu);
				
		this.listView = new ccui.ListView();
		// set list view ex direction
		this.listView.setDirection(ccui.ScrollView.DIR_VERTICAL);
		this.listView.setTouchEnabled(true);
		this.listView.setBounceEnabled(true);
		this.listView.setBackGroundImage(res.ChatBg_png);
		this.listView.setBackGroundImageScale9Enabled(true);
		this.listView.setContentSize(cc.size(size.width-6, size.height-80));
		this.listView.attr({
			x: size.width/2,
			y: size.height/2,
			anchorX: 0.5,
			anchorY: 0.5
		});
		this.listView.addEventListener(this.selectedItemEvent, this);
		this.addChild(this.listView);
		
		//request chat
		Scut.Net.Instance().send(Scut.Net.Params.extend({ActionId:3002}));
	},
	renderChat: function(data){
		var dataList = data || [];
		var fontName = 'Arial';
		var fontSize = 26;
		var prefix = 20;
		var labelWidth = this.listView.width-prefix;
		var currUserId = Scut.Net.Params.getUserId();
		var labelHight,message,default_item, nameLabel, timeLabel, isSelf,arr;
		for(var i=0; i<dataList.length; i++){
			item = dataList[i] || {};
			arr = Scut.Utils.splitStr((item.Message || ''),labelWidth -40, fontName, fontSize);
			message = arr.join('\n');
			isSelf = currUserId === item.UserId;
			
			nameLabel = new cc.LabelTTF(message, fontName, fontSize);
			nameLabel.setHorizontalAlignment(cc.TEXT_ALIGNMENT_LEFT);
			timeLabel = new cc.LabelTTF('['+item.SendTime + '] ' + item.Sender +':', fontName, fontSize);
			timeLabel.setHorizontalAlignment(cc.TEXT_ALIGNMENT_LEFT);
			labelHight = timeLabel.getContentSize().height;
			default_item = new ccui.Layout();
			default_item.setTouchEnabled(true);
			default_item.setContentSize(this.listView.width, labelHight + nameLabel.getContentSize().height+20);
			default_item.attr({
				width:this.listView.width
			});
			timeLabel.attr({
				x: isSelf ? labelWidth : prefix,
				y: default_item.height,
				anchorX: isSelf ? 1 : 0,
				anchorY: 1,
				color: cc.color.GRAY
			});
			nameLabel.attr({
				x: isSelf ? labelWidth : prefix,
				y: default_item.height - labelHight,
				anchorX: isSelf ? 1 : 0,
				anchorY: 1
			});
			default_item.addChild(timeLabel);
			default_item.addChild(nameLabel);
			this.listView.pushBackCustomItem(default_item);
		}
	}
});


var ChatScene = cc.Scene.extend({
	onEnter:function () {
		this._super();
		var layer = new ChatLayer();
		layer.setName("ChatLayer");
		this.addChild(layer);
	}
});

