<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TodoWebFormsApp._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ToDo List</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <h1>Simple To-Do List!</h1>
       
        <input type="text" id="txtTask" placeholder="Enter a new task" />
        <button type="button" id="btnAddTask">Add</button>

        <div id="taskContainer">
            <!-- Tasks will be listed here -->
        </div>

    </div>
    </form>

    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script>
        // Let's pull existing tasks when the page loads
        $(document).ready(function () {
            loadTasks();

            $("#btnAddTask").click(function () {
                var taskText = $("#txtTask").val();
                if (taskText.trim() === "") {
                    alert("Please enter a task text!");
                    return;
                }

                // POST request to the API
                $.ajax({
                    url: "/api/ToDo",
                    type: "POST",
                    data: JSON.stringify({ Text: taskText, IsCompleted: false }),
                    contentType: "application/json; charset=utf-8",
                    success: function (response) {
                        $("#txtTask").val("");
                        loadTasks();
                    },
                    error: function (err) {
                        alert("An error occured: " + err.responseText);
                    }
                });
            });
        });

        function loadTasks() {
            $.ajax({
                url: "/api/ToDo",
                type: "GET",
                success: function (data) {
                    var html = "";
                    data.forEach(function (item) {
                        html += `<div>
                            <input type="checkbox" onchange="toggleTask(${item.Id}, this.checked)" ${item.IsCompleted ? "checked" : ""} />
                            <span style="text-decoration:${item.IsCompleted ? "line-through" : "none"}">
                                ${item.Text}
                            </span>
                            <button type="button" onclick="deleteTask(${item.Id})">Delete</button>
                        </div>`;
                    });
                    $("#taskContainer").html(html);
                },
                error: function (err) {
                    alert("An error occurred while retrieving the list: " + err.responseText);
                }
            });
        }

        function toggleTask(Id, isChecked) {
            // Update IsCompleted status with PUT request
            $.ajax({
                url: "/api/ToDo/" + id,
                type: "PUT",
                data: JSON.stringify({ Id: Id, Text: "", IsCompleted: isChecked }),
                contentType: "application/json; charset=utf-8",
                success: function (response) {
                    // Refresh list after change
                    loadTasks();
                },
                error: function (err) {
                    alert("Could not update: " + err.responseText);
                }
            });
        }

        function deleteTask(Id) {
            if (!confirm("Are you sure you want to delete this task?")) return;

            $.ajax({
                url: "/api/ToDo/" + Id,
                type: "DELETE",
                success: function () {
                    loadTasks();
                },
                error: function (err) {
                    alert("Deletion failed: " + err.responseText);
                }
            });
        }
    </script>
</body>
</html>