function toggleSidebar() {
	const sidebarElem = document.getElementById("sidebar-div");
	const detailElem = document.getElementById("detail-container");
	const navIconElem = document.getElementById("nav-icon");
	sidebarElem.classList.toggle("sidebar-open")

	if(sidebarElem.style.width === "var(--sidebar-width)") {
		sidebarElem.style.width = "2%";
		detailElem.style.width = "98%";
		//searchElem.style.width = "0%";
		navIconElem.setAttribute("src", "images/right.svg");
	}
	else {
		//searchElem.style.width = "90%";
		sidebarElem.style.width = "var(--sidebar-width)";
		detailElem.style.width = "calc(100% - var(--sidebar-width))";
		navIconElem.setAttribute("src", "images/left.svg");
	}
}
function initialisePopup() {
	const popupBack = document.getElementById("popup-back-div");
	const editBtn = document.getElementById("detail-edit-icon");
	const closeBtn = document.getElementById("close-popup");
	const editForm = document.getElementById("edit-form-btn");

	editBtn.addEventListener("click", () => {
		popupBack.style.display = "flex";
	})

	closeBtn.addEventListener("click", () => {
		popupBack.style.display = "none";
	})

	editForm.addEventListener("click", () => {
		popupBack.style.display = "none";
	})
}

initialisePopup();