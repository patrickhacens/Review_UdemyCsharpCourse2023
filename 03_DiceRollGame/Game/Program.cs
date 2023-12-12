
using DiceRollGame.Game;

var random = new Random();
var dice = new Dice(random);
var guessGame = new GuessGame(dice);
GuessGame.GameResult gameResult = guessGame.Play();
GuessGame.PrintResults(gameResult);

