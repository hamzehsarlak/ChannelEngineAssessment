const orderUri = "api/v1/orders";
const offerUri = "api/v1/offers";
const getAllOrdersUri = orderUri + "/getAllOrders";
const getTopFiveMerchantProductsUri = orderUri + "/getTopFiveMerchantProducts";
const updateStockUri = offerUri + "/UpdateStock";
let orders = [];
let currentOrder;


function generateTableHead(table, data) {
    const thead = table.createTHead();
    const row = thead.insertRow();
    addHeader(row, "No");
    for (let key in data) {
        if (Object.prototype.hasOwnProperty.call(data, key)) {
            addHeader(row, data[key]);
        }
    }
    addHeader(row, "Action");
}

function addHeader(row,html) {
    const th = document.createElement("th");
    const text = document.createTextNode(html);
    th.appendChild(text);
    row.appendChild(th);
}

function generateTable(table, data, idField) {
    let index = 0;
    for (let element of data) {
        index++;
        const row = table.insertRow();
        addCell(row, index);
        let key;
        for (key in element) {
            if (Object.prototype.hasOwnProperty.call(element, key)) {
                addCell(row, element[key]);
            }
        }
        addCell(row,
            '<button type="button" class="btn btn-primary btnUpdateStock" id="' +
            element[idField] +
            '"><i class="fas fa-layer-group"></i></button>');
    }
}
function addCell(row,html) {
    const cell = row.insertCell();
    cell.innerHTML += html;
}

function initTable(tableName, dataObj) {
    $("#" + tableName).html('');
    const table = document.getElementById(tableName);
    const rows = dataObj.result;
    generateTableHead(table, dataObj.headers);
    generateTable(table, rows, dataObj.idField);
}


function getAllOrders() {
    fetch(getAllOrdersUri)
        .then(response =>
            response.json()
    )
        .then(data =>
            _displayItems(data)
    )
        .catch(error => showToast('Unable to get items.<br>' + JSON.stringify(error)));
}

function getTopFiveMerchantProducts() {
    fetch(getTopFiveMerchantProductsUri)
        .then(response =>
            response.json()
        )
        .then(data => {
            data.headers = {
                merchantProductNo: "Product No",
                gtin: "Gtin",
                quantity: "Quantity",
                description: "Description"
            };
            data.idField = "merchantProductNo";
            orders = data;
            _displayItems(data);
        })
        .catch(error => showToast('Unable to get items.' + JSON.stringify(error)));
}

function updateStock(stock) {

    fetch(updateStockUri, {
            method: 'PUT',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                merchantProductNo: currentOrder.merchantProductNo,
                stock: stock
            })
        })
        .then(() => {
            $("#editStockModal").modal('toggle');
            showToast('Stock of ' + currentOrder.description + ' has been successfully updated.');
            getTopFiveMerchantProducts();
        })
        .catch(error => showToast('Unable to update item.<br>'+JSON.stringify(error)));
}

$(document).ready(function() {
    $('#editStockModal').on('click', '.btnUpdateStockCall', function () {
        updateStock();
    });
    $('#ordersTable').on('click', '.btnUpdateStock', function () {
        $("#editStockModal").modal('toggle');
        const id = this.id;
        const modal = $("#editStockModal");
        currentOrder = getOrderById(id);
        modal.find('.modal-title').text('Update stock of ' + currentOrder.description);
        modal.find("#stockInput").val(currentOrder.quantity);
    });
});

function showToast(text) {
    $("#toast").find('.modal-body').html(text);
    $("#toast").modal('toggle');
}

function getOrderById(id) {
    if (!orders || !orders.result) return null;
    let item = orders.result.find(function (order, index) {
        if (order.merchantProductNo === id)
            return order;
        return null;
    });
    return item;
}

function _displayItems(data) {
    initTable("ordersTable", data);
}