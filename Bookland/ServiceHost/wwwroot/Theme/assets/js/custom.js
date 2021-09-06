const cookieName = "cart_items";

function addToCart(id, name, price, picture, slug) {
    let products = $.cookie(cookieName);
    if (products === undefined) {
        products = [];
    } else {
        products = JSON.parse(products);
    }

    const count = $("#quantity1").val();
    const currentProduct = products.find(x => x.id == id);

    if (currentProduct !== undefined) {
        products.find(x => x.id == id).count = parseInt(currentProduct.count) + parseInt(count);
    } else {
        const product = {
            id,
            name,
            unitPrice: price,
            picture,
            count,
            slug
        }
        products.push(product);
    }

    $.cookie(cookieName, JSON.stringify(products), { expires: 2, path: "/" });
    updateCart();
}

function updateCart() {
    var totalPrice = 0;
    let products = $.cookie(cookieName);
    if (products != undefined) {
        products = JSON.parse(products);
        $("#cart_items_count").text(products.length);
        Array.from(products).forEach(x => {
            var price = x.unitPrice;
            var count = x.count;
            var productTotalPrice = count * price;
            totalPrice = totalPrice + productTotalPrice;
        })
        totalPrice = separate(totalPrice);
        $("#totalPrice1").text(totalPrice)
        $("#totalPrice2").text("جمع کل: " + totalPrice)
        const cartItemsWrapper = $("#cart_items_wrapper");
        cartItemsWrapper.html('');
        products.forEach(x => {
            const product = `<div class="tg-minicarproduct">
                                                    <a class="fa fa-remove" href="javascript:void(0)" onclick="removeFromCart('${x.id}')" style="float: left;"> </a>
                                                <figure>
                                                    <img src="/Pictures/${x.picture}" style='width: 70px'>
                                                </figure>
                                                <div class="tg-minicarproductdata">
                                                    <h6><a asp-page="/BookDetail" asp-route-id="${x.slug}">${x.name}</a></h6>
                                                    <h5><a>${separate(x.unitPrice)} تومان</a ></h5 >
                                                    <h5><a>تعداد: ${x.count} </a></h5>
                                                </div>
                                            </div>`;
            cartItemsWrapper.append(product);
        });
    }
}

function removeFromCart(id) {
    let products = $.cookie(cookieName);
    products = JSON.parse(products);
    let itemToRemove = products.findIndex(x => x.id == id);
    products.splice(itemToRemove, 1);

    $.cookie(cookieName, JSON.stringify(products), { expires: 2, path: "/" });
    updateCart();
}

function changeCartItemCount(id, totalId, count) {
    var products = $.cookie(cookieName);
    products = JSON.parse(products);
    const productIndex = products.findIndex(x => x.id == id);
    products[productIndex].count = count;
    const product = products[productIndex];
    const newPrice = parseInt(product.unitPrice) * parseInt(count);
    $(`#${totalId}`).text(newPrice);

    $.cookie(cookieName, JSON.stringify(products), { expires: 2, path: "/" });
    updateCart();

    const settings = {
        "url": "https://localhost:5001/api/inventory",
        "method": "POST",
        "timeout": 0,
        "headers": {
            "Content-Type": "application/json"
        },
        "data": JSON.stringify({
            "bookId": id,
            "count": count
        }),
    };

    //$.ajax(settings).done(function (data) {
    //    debugger;
    //    if (data.isInStock == false) {
    //        const warningsDiv = $('#productStockWarnings');
    //        if ($(`#${id}`).length == 0) {
    //            warningsDiv.append(`
    //                <div class="alert alert-warning" id="${id}">
    //                    <i class="fa fa-warning"></i>
    //                            کالای <strong>${data.productName}</strong> در انبار کمتر از تعداد درخواستی موجود است.
    //                </div>
    //            `)
    //        }
    //        else {
    //            if ($(`#${id}`).length > 0) {
    //                $(`#${id}`).remove();
    //            }
    //        }
    //    }
    //});

    $.ajax(settings).done(function (data) {
        debugger;
        if (data.isInStock == false) {
            const warningsDiv = $('#productStockWarnings');
            if ($(`#${id}`).length == 0) {
                warningsDiv.append(`
                    <div class="alert alert-warning" id="${id}">
                        <i class="fa fa-warning"></i> کالای
                        <strong>${data.bookName}</strong>
                        در انبار کمتر از تعداد درخواستی موجود است.
                    </div>
                `);
            }
        } else {
            if ($(`#${id}`).length > 0) {
                $(`#${id}`).remove();
            }
        }
    });
}

function separate(Number) {
    Number += '';
    Number = Number.replace(',', '');
    x = Number.split('.');
    y = x[0];
    z = x.length > 1 ? '.' + x[1] : '';
    var rgx = /(\d+)(\d{3})/;
    while (rgx.test(y))
        y = y.replace(rgx, '$1' + ',' + '$2');
    return y + z;
}