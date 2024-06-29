import * as request from "../utils/request"

export const loginStudent = async (id, obj) => {
  try {
    const res = await request.postMethod(`events/${id}/checkin`, true, obj)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const genQR = async (id, obj) => {
  try {
    const res = await request.postMethod(`events/${id}/qr`, true, obj)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}
