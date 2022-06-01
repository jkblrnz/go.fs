: empty		s" ---marker--- marker ---marker---" evaluate ;
: edit		s" emacsclient -t test.fs" system ;
: run		s" test.fs" included ;
: ecr		edit run ;

marker ---marker---
