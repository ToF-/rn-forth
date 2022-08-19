create romans 10 allot


: init-romans
  0 romans c! ;

: c>romans ( c -- )
  romans dup c@ 1+
  2dup swap c!
  + c! ;

: decimal>roman ( u -- )
  init-romans
  0 do
    [char] I c>romans
  loop ;

