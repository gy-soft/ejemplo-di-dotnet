const TOKEN = "7b7c78v89cv99vb09c665bc5n5vbnc6";

function authorize(req) {
    const bearer = req.get('Authorization');
    const tokens = bearer.split(' ');
    return tokens[1] == TOKEN;
}

exports.authorize = authorize;