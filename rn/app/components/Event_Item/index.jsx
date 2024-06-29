import React from "react"
import { Text, TouchableOpacity, View, Image, Linking } from "react-native"
import { format } from "date-fns"
import logo from "../../../assets/images/anhtruong.jpg"
import { FontAwesomeIcon } from "@fortawesome/react-native-fontawesome"
import { faEye, faEyeSlash, faFileExport } from "@fortawesome/free-solid-svg-icons"
import { useRouter, Link } from "expo-router"

import * as EventServices from '../../apiServices/eventServices'
import dayjs from "dayjs"

function Event_Item({ item, deleteItem, deleteButton }) {
  const router = useRouter()

  const exportFile = async () => {
    const response = await EventServices.getCheckinFile({
      EventId: item.id
    }).catch((error) => {
      showToastWithGravity("Có lỗi xảy ra")
      console.log(error);
    })

    if (response) {
      // Xử lý nếu response trả về
      Linking.openURL(response.fileUrl).catch(err => console.error("Couldn't load page", err));
    }
  }

  return (
    <Link
      href={{
        pathname: "(page)/post-detail/[id]",
        params: {
          id: item.id,
        },
      }}
      className='my-[5px] h-[90px] rounded-lg bg-white flex-row'
      style={{
        shadowColor: "#000",
        shadowOffset: {
          width: 0,
          height: 2,
        },
        shadowOpacity: 0.23,
        shadowRadius: 2.62,

        elevation: 4,
      }}

      onPress={() => {}}
    >
      <View className='h-[90px] w-[100%] flex-row items-center'>
        <Image
          source={item?.images ? { uri: item?.images[0].imageUrl } : logo}
          className='mx-2 h-[80px] w-[80px] rounded-[3px] bg-white'
        />

        <View className='flex-1'>
          <Text numberOfLines={2} className='mb-3 font-semibold text-xs'>
            {item.title}
          </Text>
          <View className='flex-row justify-between w-full'>
            {item.isPublished === true ? (
              <Text className='text-xs'>
                Ngày công bố : {dayjs(item?.publishedDate).format("HH:mm - DD/MM/YYYY")}
              </Text>
            ) : (
              <Text className='text-xs'>
                Thời gian bắt đầu :{" "}
                {dayjs(item?.startDate).format("HH:mm - DD/MM/YYYY")}
              </Text>
            )}
            <TouchableOpacity className=' flex-1 flex items-center justify-center' onPress={() => exportFile()}>
              <FontAwesomeIcon
                icon={faFileExport}
              />
            </TouchableOpacity>
          </View>
        </View>

        {/* {deleteButton && (
          <TouchableOpacity className=' mr-2 flex-1 flex items-center justify-center'>
            <View className='rounded-full bg-orange-400 p-3'>
              <FontAwesomeIcon
                icon={item.isPublished === true ? faEye : faEyeSlash}
                color='white'
              />
            </View>
          </TouchableOpacity>
        )} */}

      </View>


    </Link>
  )
}

export default Event_Item
