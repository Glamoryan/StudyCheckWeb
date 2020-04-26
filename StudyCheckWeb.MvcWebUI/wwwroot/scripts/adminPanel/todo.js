const form = document.querySelector("#todo-form");
const todoInput = document.querySelector("#mesaj");
const todoInputSure = document.querySelector("#sure");
const todoList = document.querySelector("#todoList");
const firstBody = document.querySelector(".modal-body");
//const secondBody = document.querySelector(".card-body");

eventListeners();

function eventListeners() {
    form.addEventListener("submit", addTodo);
    document.addEventListener("DOMContentLoaded", loadAllTodosToUI);
}

function deleteTodoFromStorage(el) {
    let todos = getTodosFromStorage();
    todos.forEach(function (todo, index) {
        if (todo[0] === el) {
            todos.splice(index, 1);            
        }
    });
    localStorage.setItem("todos", JSON.stringify(todos));
}

function bilgiAl() {
    var msg = document.getElementById("mesaj").value;
    var tm = document.getElementById("sure").value;
    ekle(msg, tm);
}

function addTodo(e) {
    const newTodo = [todoInput.value.trim(), todoInputSure.value.trim()];
    const varmi = getTodosFromStorage();
    let mevcut = false;
    varmi.forEach(function (todo) {
        if (todo === newTodo) {
            return mevcut = true;
        }
    });
    if (newTodo === "") {
        alert("Boş geçilemez");
    } else if (mevcut) {
        alert("Zaten mevcut");
    } else {
        ekle(newTodo);
        addTodoToStorage(newTodo);
    }
    e.preventDefault();
}

function addTodoToStorage(newTodo) {
    let todos = getTodosFromStorage();
    todos.push(newTodo);
    localStorage.setItem("todos", JSON.stringify(todos));
}

function ekle(todo) {    
    var adet = document.getElementById("todoList").getElementsByTagName("li").length + 1;
    var li = document.createElement("li");
    li.innerHTML = `
                    <span class="handle">
                    <i class="fas fa-ellipsis-v"></i>
                    <i class="fas fa-ellipsis-v"></i>
                    </span>
                    <div class="icheck-primary d-inline ml-2">
                    <input type="checkbox" value="" name="todo${adet}" id="todoCheck${adet}">
                    <label for="todoCheck${adet}"></label>
                    </div>
                    <span class="text">${todo[0]}</span>
                    <small class="badge badge-primary"><i class="far fa-clock"></i>${todo[1]}</small>
                    <div class="tools">
                    <i onclick="cikar(this)" class="fas fa-trash"></i>
                    <i class="fas fa-trash-o"></i>
                    </div>`;
    document.getElementById("todoList").appendChild(li);
    todoInput.value = "";
}

function cikar(el) {
    if (el.className === "fas fa-trash") {
        var tools = el.parentElement;
        var li = tools.parentElement;
        var text = li.getElementsByTagName('span')[1].textContent;        
        li.remove();
        deleteTodoFromStorage(text);        
    }        
}

function getTodosFromStorage() {
    let todos;
    if (localStorage.getItem("todos") === null) {
        todos = [];
    } else {
        todos = JSON.parse(localStorage.getItem("todos"));
    }
    return todos;
}

function loadAllTodosToUI() {
    let todos = getTodosFromStorage();
    todos.forEach(function (todo) {
        ekle(todo);
    });
}