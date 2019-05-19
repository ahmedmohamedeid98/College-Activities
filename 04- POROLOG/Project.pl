% Author:
% Date: 5/11/2019

unionFunction([H|T],Y,Z):-memberList(H,Y),unionFunction(T,Y,Z).
unionFunction([H|T],Y,[H|Z]):- \+ memberList(H,Y),unionFunction(T,Y,Z).
unionFunction([],Y,Y).


%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
memberList(X,[X|_]).
memberList(X,[_|T]):-memberList(X,T).


%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
intersectionFunction([H|T],Y,[H|Z]):-memberList(H,Y),intersectionFunction(T,Y,Z).
intersectionFunction([H|T],Y,Z):- \+ memberList(H,Y),intersectionFunction(T,Y,Z).
intersectionFunction([],Y,[]).


%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

subsetFunction(X,Y):- subsetAcc(X,Y,Y).

subsetAcc([], [_|_], [_|_]).
subsetAcc([H|X],[H|Y],A) :- subsetAcc(X, A, A).
subsetAcc([H|X],[Y|Z],A) :- subsetAcc([H|X], Z, A).


%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
mergeFunction([H|T],Y,[H|Z]):-mergeFunction(T,Y,Z).
mergeFunction([],Y,Y).


%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


deleteSet(H,[H|T],T).
deleteSet(X,[H|T],[H|Z]):-deleteSet(X,T,Z).

%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

lenSet([], 0).
lenSet([X|T],N):- lenSet(T, OldN), N is OldN + 1.




