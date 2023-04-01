const { createApp, nextTick, onMounted, ref, getCurrentInstance } = Vue



var Vuejs = createApp({
    data() {
        return {
            AnhDaiDien: "../img/NoImg.png",
            dulieuDV: { TrangThai: '1', Ten: '', MoTa: '' },
            DonVi: [],
            option: {
                pageSize: 15,
                paging: "scroll"
            },
            cols: [
                { id: "TenPhu", name: "Tên đơn vị", field: "TenPhu", minWidth: 200, filterType: "text" },
                { id: "DiaChi", name: "Địa chỉ", field: "DiaChi", minWidth: 180, filterType: "text" },
                { id: "SoDienThoai", name: "Số điện thoại", field: "SoDienThoai", minWidth: 100, filterType: "text" },
                { id: "Email", name: "Email", field: "Email", minWidth: 130, filterType: "text" },
                { id: "Chon", name: "Thao tác", field: "chon", minWidth: 80, formatter: AddButton, filterType: "none" }
            ]
        }
    },
    setup(props, ctx) {


        onMounted(() => {
            //LoadDanhSachDonVi();
        });

        function ThemDonVi() {
            Vuejs.$bvModal.show("DonViModel");
            //resetValue();
        }

        function LuulaiThongTin() {

            if (!checkIsValid("DonViModel")) {
                return false;
            }

            var newUrl = danhMuc.urlDonViNhap;
            $.ajax({
                type: "POST",
                data: JSON.stringify(Vuejs.dulieuDV),
                url: newUrl,
                dataType: "json",
                success: function (b_data) {
                    Vuejs.$refs.GridDonVi.setDataSource(b_data);
                    Vuejs.$bvModal.hide("DonViModel");
                }
            });

        }

        return {
            ThemDonVi,
            LuulaiThongTin
        }
    }

}).mount('#DonVi')


function resetValue() {
    Vuejs.dulieuDV = { TrangThai: '1', Ten: '', MoTa: '' };
}


function LoadDanhSachDonVi() {
    var newUrl = danhMuc.urlDonViLietKe;
    $.ajax({
        type: "GET",
        url: newUrl,
        dataType: "json",
        success: function (b_data) {
            Vuejs.DonVi = [];

            b_data.forEach(function (val, index) {
                Vuejs.DonVi.push({ "id": val.IdDonVi, "text": val.TenDonVi });
            });

            Vuejs.$refs.GridDonVi.setDataSource(b_data);
        }
    });
}

function AddButton(row, cell, value, columnDef, dataContext) {
    if (value != "") {
        var str = "";
        str = " <div style = 'text-align: center; width:100%;'> <button  class='btn btn-info btn-sm' onclick=\"Xemchitiet('" + dataContext.IdDonVi + "')\"><i class='glyphicon glyphicon-edit'></i></button><button  onclick=\"Xoathongtin('" + dataContext.IdDonVi + "', '" + row + "')\" class='btn btn-danger btn-sm'><i class='glyphicon glyphicon-remove'></i></button></div> ";

        return str;
    }
    else return value;
}

function Xoathongtin(so_id, index) {

    confirmBox(function (dialog, msg) {
        if (msg == "YES") {
            var url = danhMuc.urlDonViXoa + "?id=" + so_id;
            $.ajax({
                type: "GET",
                url: url,
                success: function (b_data) {
                    Vuejs.$refs.GridDonVi.deleteRow(index);
                }
            });

            dialog.close();
        }
    });
}

function Xemchitiet(so_id) {

    var b_tim = Vuejs.$refs.GridDonVi.getDataFilter(["IdDonVi"], [so_id], ["=="]);
    if (b_tim.length == 0) {
        return;
    }

    Vuejs.dulieuDV = b_tim[0];
    Vuejs.$bvModal.show("DonViModel");
}
