require ffl/tst.fs
require rn.fs

page

." given 1 produce string I" cr
t{ 
  1 decimal>roman
  romans count s" I" ?str
}t
bye
