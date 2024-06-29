import * as request from "../utils/request"
export const getRegisteredEvents = async () => {
  try {
    const res = await request.getMethod("students/me/events", true)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}

export const getMe = async () => {
  try {
    const res = await request.getMethod("users/students/me", true)
    return res
  } catch (error) {
    return Promise.reject(error)
  }
}
