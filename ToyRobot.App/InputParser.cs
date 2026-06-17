namespace ToyRobot.App;

public class InputParser
{
    public static RobotAction Parse(string input)
    {
        var parts = input.Split(' ');
        var arguments = parts[1];

        var command = parts[0].ToUpper() switch
        {
            "PLACE" => Command.Place,
            "MOVE" => Command.Move,
            "LEFT" => Command.Left,
            "RIGHT" => Command.Right,
            "REPORT" => Command.Report,
            _ => Command.Invalid
        };

        return !arguments.Contains(',') ?
            new RobotAction(command, Placement.Empty) :
            new RobotAction(command, Placement.Parse(arguments));
    }
}