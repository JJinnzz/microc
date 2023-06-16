module CLex

/// Rule Token
val Token: lexbuf: LexBuffer<char> -> token
/// Rule Comment
val Comment: lexbuf: LexBuffer<char> -> token
/// Rule EndLineComment
val EndLineComment: lexbuf: LexBuffer<char> -> token
/// Rule String
val String: chars: obj -> lexbuf: LexBuffer<char> -> token
/// Rule CommentAnother
val CommentAnother: lexbuf: LexBuffer<char> -> token
