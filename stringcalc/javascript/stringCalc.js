module.exports = {
	add: function(input){
		var result = 0;
		if (input && input.length) {
			var pieces  = input.split(",");
			pieces = pieces.map(function(piece){
				return parseInt(piece, 10); // NaN
			});
			
			pieces.forEach(function(piece){
				if (piece < 0){
					throw new Error("Hey, no negative numbers dummy");
				}
				result += piece;
			});
			
		}
		return result;	
	}
};
