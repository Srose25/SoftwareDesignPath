let participantCount = 1;

const addButton = document.querySelector("#add-participant");
const form = document.querySelector("form");
const summary = document.querySelector("#sumarry");

addButton.addEventListener("click", () => {
    participantCount++;
    const newParticipantHTML = participantTemplate(participantCount);

    addButton.insertAdjacentHTML("beforebegin", newParticipantHTML);
})

function participantTemplate(count) {
    return `
    <section class="participant">
    <p>Participant ${count}</p>
    <div class="item">
        <label for="fname${count}">First Name<span>*</span></label>
        <input id="fname${count}" type="text" name="fname" required>
      </div>
      <div class="item">
        <label for="activity${count}">Activity #<span>*</span></label>
        <input id="activity${count}" type="text" name="activity">
      </div>
      <div class="item">
        <label for="fee${count}">Fee ($)<span>*</span></label>
        <input id="fee${count}" type="number" name="fee">
      </div>
      <div class="item">
        <label for="date${count}">Desired Date<span>*</span></label>
        <input id="date${count}" type="date" name="date">
      </div>
      <div class="item">
        <p>Grade</p>
        <select id="grade${count}" name="grade">
          <option selected disabled value="">Select a grade</option>
          <option value="1">1st</option>
          <option value="2">2nd</option>
          <option value="3">3rd</option>
          <option value="4">4th</option>
          <option value="5">5th</option>
          <option value="6">6th</option>
          <option value="7">7th</option>
          <option value="8">8th</option>
          <option value="9">9th</option>
          <option value="10">10th</option>
          <option value="11">11th</option>
          <option value="12">12th</option>
        </select>
      </div>
    </section>
    `;
}

function successTemplate(info) {
    return `
    <p> Thank you ${info.name} for registering.</p>
    <p> You have registered ${info.participants} participant(s) and owe $${info.total} in fees.</p>
    `;
}

function submitForm(event) {
    event.preventDefault();

    const adultName = document.querySelector("#adult_name").value;
    const participants = document.querySelectorAll(".participant").length;
    const total = totalFees();

    const info = {
        name: adultName,
        participants: participants,
        total: total
    };

    form.classList.add("hide");
    summary.classList.remove("hide");

    summary.innerHTML = successTemplate(info);
}

function totalFees() {
    let feeElements = document.querySelectorAll("[id^=fee]");
    feeElements = [...feeElements];
    const total = feeElements.reduce((sum, input) => sum + (Number(input.value) || 0), 0);
    return total;
}

form.addEventListener("submit", submitForm);