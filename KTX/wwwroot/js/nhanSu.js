const { createApp, nextTick, onMounted, ref, getCurrentInstance } = Vue



var Vuejs = createApp({
    data() {
        return {
            dulieuNhap: { TrangThai: '1', Ten: '', MoTa: '' },
            duLieuTimKiem: { IdPhongBan: "" },
            AnhDaiDien: "../img/NoImg.png",
            option: {
                pageSize: 15,
                paging: "scroll"
            },
            cols: [
                { id: "Ma", name: "Mã nhân viên", field: "Ma", minWidth: 150, filterType: "text" },
                { id: "Ten", name: "Họ và tên", field: "Ten", minWidth: 200, filterType: "text" },
                { id: "GioiTinh", name: "Giới tính", field: "GioiTinh", minWidth: 100, filterType: "text" },
                { id: "NgaySinh", name: "Ngày sinh", field: "NgaySinh", minWidth: 130, filterType: "text" },
                { id: "ThuongTru", name: "Địa chỉ", field: "ThuongTru", minWidth: 250, filterType: "text" },
                { id: "Chon", name: "Thao tác", field: "chon", minWidth: 80, formatter: AddButton, filterType: "none" }
            ]
        }
    },
    setup(props, ctx) {

        onMounted(() => {
            loadThongTinPhongBan();
        });

        function ThemDonVi() {
            Vuejs.$bvModal.show("NhanSuModel");
            // resetValue();
        }

        function LuulaiThongTin() {

            if (!checkIsValid("NhanSuModel")) {
                return false;
            }

            var newUrl = danhMuc.urlDonViNhap;
            $.ajax({
                type: "POST",
                data: JSON.stringify(Vuejs.dulieuDV),
                url: newUrl,
                dataType: "json",
                success: function (b_data) {
                    debugger;
                    Vuejs.$refs.GridDonVi.setDataSource(b_data);
                    Vuejs.$bvModal.hide("NhanSuModel");
                }
            });

        }

        return {
            ThemDonVi,
            timKiemNhanSu,
            LuulaiThongTin
        }
    }

}).mount('#NhanSu');



function AddButton(row, cell, value, columnDef, dataContext) {
    if (value != "") {
        var str = "";
        str = " <div style = 'text-align: center; width:100%;'> <button  class='btn btn-info btn-sm' onclick=\"Xemchitiet('" + dataContext.IdDonVi + "')\"><i class='glyphicon glyphicon-edit'></i></button><button  onclick=\"Xoathongtin('" + dataContext.IdDonVi + "', '" + row + "')\" class='btn btn-danger btn-sm'><i class='glyphicon glyphicon-remove'></i></button></div> ";

        return str;
    }
    else return value;
}

function loadThongTinPhongBan() {
    var newUrl = danhMuc.urlPhongBanLietKe;

    $.ajax({
        type: "GET",
        url: newUrl,
        dataType: "json",
        success: function (b_data) {
            Vuejs.dsPhongBan = [];
            b_data.forEach(function (val, index) {
                Vuejs.dsPhongBan.push({ "id": val.Id, "text": val.Ten });
            });
        }
    });
}

function timKiemNhanSu() {
    var b_phong = Vuejs.duLieuTimKiem.IdPhongBan;

    var newUrl = nhanSu.urlNhanSuLietKe + "?IdPhong=" + b_phong;
    $.ajax({
        type: "GET",
        url: newUrl,
        dataType: "json",
        success: function (b_data) {
            Vuejs.$refs.gridNhanSu.setDataSource(b_data);
        }
    });
}